using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace ExtremeDumper.AntiAntiDump.Handlers;

sealed class GetMetadataInfoHandler : ICommandHandler {
	public AADCommand Command => AADCommand.GetMetadataInfo;

	public Type ParametersType => typeof(ModuleInfo);

	public Type ResultType => typeof(MetadataInfo);

	public bool Execute(ISerializable parameters_, [NotNullWhen(true)] out ISerializable? result_) {
		result_ = null;
		if (parameters_ is not ModuleInfo parameters)
			return false;

		var module = FindModule(parameters);
		if (module is null)
			return false;

		var metadataProvider = MetadataLocator.MetadataInfo.Create(module);
		var metadata = new MetadataInfo(metadataProvider);
		result_ = metadata;
		return true;
	}

	Module? FindModule(ModuleInfo moduleInfo) {
		var domain = AppDomain.CurrentDomain;
		if (domain.Id != moduleInfo.DomainId)
			return null;

		foreach (var assembly in domain.GetAssemblies()) {
			var assemblyName = assembly.GetName().Name;
			if (assemblyName != moduleInfo.AssemblyName)
				continue;

			foreach (var module in assembly.GetLoadedModules()) {
				if (module.ScopeName == moduleInfo.Name)
					return module;
			}
		}

		return null;
	}
}
