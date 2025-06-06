// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information

/*
IMPORTANT NOTE
==============
This file has been generated. 
If you wish to submit a PR please modify the original csharp file and submit the PR with that change. Thanks!
*/

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.CommonSchema.Serialization
{
	public partial class EcsDocumentJsonConverter<TBase> : EcsJsonConverterBase<TBase>
		where TBase : EcsDocument, new()
	{
		private static bool ReadProperties(
			ref Utf8JsonReader reader, 
			TBase ecsEvent, 
			ref DateTimeOffset? timestamp, 
			ref string loglevel,
			ref string ecsVersion,
			JsonSerializerOptions options
		)
		{
			var propertyName = reader.GetString();
			reader.Read();
			return propertyName switch
			{
				"log.level" => ReadString(ref reader, ref loglevel),
				"ecs.version" => ReadString(ref reader, ref ecsVersion),
				"metadata" => ReadProp<MetadataDictionary>(ref reader, "metadata", ecsEvent, (b, v) => b.Metadata = v, options),
				"@timestamp" => ReadDateTime(ref reader, ref @timestamp, options),
				"message" => ReadProp<string>(ref reader, "message", ecsEvent, (b, v) => b.Message = v, options),
				"tags" => ReadProp<string[]>(ref reader, "tags", ecsEvent, (b, v) => b.Tags = v, options),
				"span.id" => ReadProp<string>(ref reader, "span.id", ecsEvent, (b, v) => b.SpanId = v, options),
				"trace.id" => ReadProp<string>(ref reader, "trace.id", ecsEvent, (b, v) => b.TraceId = v, options),
				"transaction.id" => ReadProp<string>(ref reader, "transaction.id", ecsEvent, (b, v) => b.TransactionId = v, options),
				"labels" => ReadProp<Labels>(ref reader, "labels", ecsEvent, (b, v) => b.Labels = v, options),
				"agent" => ReadProp<Agent>(ref reader, "agent", EcsJsonContext.Default.Agent, ecsEvent, (b, v) => b.Agent = v),
				"as" => ReadProp<As>(ref reader, "as", EcsJsonContext.Default.As, ecsEvent, (b, v) => b.As = v),
				"client" => ReadProp<Client>(ref reader, "client", EcsJsonContext.Default.Client, ecsEvent, (b, v) => b.Client = v),
				"cloud" => ReadProp<Cloud>(ref reader, "cloud", EcsJsonContext.Default.Cloud, ecsEvent, (b, v) => b.Cloud = v),
				"code_signature" => ReadProp<CodeSignature>(ref reader, "code_signature", EcsJsonContext.Default.CodeSignature, ecsEvent, (b, v) => b.CodeSignature = v),
				"container" => ReadProp<Container>(ref reader, "container", EcsJsonContext.Default.Container, ecsEvent, (b, v) => b.Container = v),
				"data_stream" => ReadProp<DataStream>(ref reader, "data_stream", EcsJsonContext.Default.DataStream, ecsEvent, (b, v) => b.DataStream = v),
				"destination" => ReadProp<Destination>(ref reader, "destination", EcsJsonContext.Default.Destination, ecsEvent, (b, v) => b.Destination = v),
				"device" => ReadProp<Device>(ref reader, "device", EcsJsonContext.Default.Device, ecsEvent, (b, v) => b.Device = v),
				"dll" => ReadProp<Dll>(ref reader, "dll", EcsJsonContext.Default.Dll, ecsEvent, (b, v) => b.Dll = v),
				"dns" => ReadProp<Dns>(ref reader, "dns", EcsJsonContext.Default.Dns, ecsEvent, (b, v) => b.Dns = v),
				"ecs" => ReadProp<Ecs>(ref reader, "ecs", EcsJsonContext.Default.Ecs, ecsEvent, (b, v) => b.Ecs = v),
				"elf" => ReadProp<Elf>(ref reader, "elf", EcsJsonContext.Default.Elf, ecsEvent, (b, v) => b.Elf = v),
				"email" => ReadProp<Email>(ref reader, "email", EcsJsonContext.Default.Email, ecsEvent, (b, v) => b.Email = v),
				"error" => ReadProp<Error>(ref reader, "error", EcsJsonContext.Default.Error, ecsEvent, (b, v) => b.Error = v),
				"event" => ReadProp<Event>(ref reader, "event", EcsJsonContext.Default.Event, ecsEvent, (b, v) => b.Event = v),
				"faas" => ReadProp<Faas>(ref reader, "faas", EcsJsonContext.Default.Faas, ecsEvent, (b, v) => b.Faas = v),
				"file" => ReadProp<File>(ref reader, "file", EcsJsonContext.Default.File, ecsEvent, (b, v) => b.File = v),
				"geo" => ReadProp<Geo>(ref reader, "geo", EcsJsonContext.Default.Geo, ecsEvent, (b, v) => b.Geo = v),
				"group" => ReadProp<Group>(ref reader, "group", EcsJsonContext.Default.Group, ecsEvent, (b, v) => b.Group = v),
				"hash" => ReadProp<Hash>(ref reader, "hash", EcsJsonContext.Default.Hash, ecsEvent, (b, v) => b.Hash = v),
				"host" => ReadProp<Host>(ref reader, "host", EcsJsonContext.Default.Host, ecsEvent, (b, v) => b.Host = v),
				"http" => ReadProp<Http>(ref reader, "http", EcsJsonContext.Default.Http, ecsEvent, (b, v) => b.Http = v),
				"interface" => ReadProp<Interface>(ref reader, "interface", EcsJsonContext.Default.Interface, ecsEvent, (b, v) => b.Interface = v),
				"log" => ReadProp<Log>(ref reader, "log", EcsJsonContext.Default.Log, ecsEvent, (b, v) => b.Log = v),
				"macho" => ReadProp<Macho>(ref reader, "macho", EcsJsonContext.Default.Macho, ecsEvent, (b, v) => b.Macho = v),
				"network" => ReadProp<Network>(ref reader, "network", EcsJsonContext.Default.Network, ecsEvent, (b, v) => b.Network = v),
				"observer" => ReadProp<Observer>(ref reader, "observer", EcsJsonContext.Default.Observer, ecsEvent, (b, v) => b.Observer = v),
				"orchestrator" => ReadProp<Orchestrator>(ref reader, "orchestrator", EcsJsonContext.Default.Orchestrator, ecsEvent, (b, v) => b.Orchestrator = v),
				"organization" => ReadProp<Organization>(ref reader, "organization", EcsJsonContext.Default.Organization, ecsEvent, (b, v) => b.Organization = v),
				"os" => ReadProp<Os>(ref reader, "os", EcsJsonContext.Default.Os, ecsEvent, (b, v) => b.Os = v),
				"package" => ReadProp<Package>(ref reader, "package", EcsJsonContext.Default.Package, ecsEvent, (b, v) => b.Package = v),
				"pe" => ReadProp<Pe>(ref reader, "pe", EcsJsonContext.Default.Pe, ecsEvent, (b, v) => b.Pe = v),
				"process" => ReadProp<Process>(ref reader, "process", EcsJsonContext.Default.Process, ecsEvent, (b, v) => b.Process = v),
				"registry" => ReadProp<Registry>(ref reader, "registry", EcsJsonContext.Default.Registry, ecsEvent, (b, v) => b.Registry = v),
				"related" => ReadProp<Related>(ref reader, "related", EcsJsonContext.Default.Related, ecsEvent, (b, v) => b.Related = v),
				"risk" => ReadProp<Risk>(ref reader, "risk", EcsJsonContext.Default.Risk, ecsEvent, (b, v) => b.Risk = v),
				"rule" => ReadProp<Rule>(ref reader, "rule", EcsJsonContext.Default.Rule, ecsEvent, (b, v) => b.Rule = v),
				"server" => ReadProp<Server>(ref reader, "server", EcsJsonContext.Default.Server, ecsEvent, (b, v) => b.Server = v),
				"service" => ReadProp<Service>(ref reader, "service", EcsJsonContext.Default.Service, ecsEvent, (b, v) => b.Service = v),
				"source" => ReadProp<Source>(ref reader, "source", EcsJsonContext.Default.Source, ecsEvent, (b, v) => b.Source = v),
				"threat" => ReadProp<Threat>(ref reader, "threat", EcsJsonContext.Default.Threat, ecsEvent, (b, v) => b.Threat = v),
				"tls" => ReadProp<Tls>(ref reader, "tls", EcsJsonContext.Default.Tls, ecsEvent, (b, v) => b.Tls = v),
				"url" => ReadProp<Url>(ref reader, "url", EcsJsonContext.Default.Url, ecsEvent, (b, v) => b.Url = v),
				"user" => ReadProp<User>(ref reader, "user", EcsJsonContext.Default.User, ecsEvent, (b, v) => b.User = v),
				"user_agent" => ReadProp<UserAgent>(ref reader, "user_agent", EcsJsonContext.Default.UserAgent, ecsEvent, (b, v) => b.UserAgent = v),
				"vlan" => ReadProp<Vlan>(ref reader, "vlan", EcsJsonContext.Default.Vlan, ecsEvent, (b, v) => b.Vlan = v),
				"volume" => ReadProp<Volume>(ref reader, "volume", EcsJsonContext.Default.Volume, ecsEvent, (b, v) => b.Volume = v),
				"vulnerability" => ReadProp<Vulnerability>(ref reader, "vulnerability", EcsJsonContext.Default.Vulnerability, ecsEvent, (b, v) => b.Vulnerability = v),
				"x509" => ReadProp<X509>(ref reader, "x509", EcsJsonContext.Default.X509, ecsEvent, (b, v) => b.X509 = v),
				_ =>
					typeof(EcsDocument) == ecsEvent.GetType()
						? false
						: ecsEvent.TryRead(propertyName, out var t)
							? ecsEvent.ReceiveProperty(propertyName, ReadPropDeserialize(ref reader, t, options))
							: false
			};
		}

		/// <inheritdoc cref="JsonConverter{T}.Write"/>
		public override void Write(Utf8JsonWriter writer, TBase value, JsonSerializerOptions options)
		{
			if (value == null)
			{
				writer.WriteNullValue();
				return;
			}
			writer.WriteStartObject();

			WriteTimestamp(writer, value, options);
			WriteLogLevel(writer, value);
			WriteMessage(writer, value);
			WriteEcsVersion(writer, value);
			WriteLogEntity(writer, value.Log, options);
			WriteEcsEntity(writer, value.Ecs, options);

			// Base fields
			WriteProp(writer, "tags", value.Tags, options);
			WriteProp(writer, "span.id", value.SpanId, options);
			WriteProp(writer, "trace.id", value.TraceId, options);
			WriteProp(writer, "transaction.id", value.TransactionId, options);
			WriteProp(writer, "labels", value.Labels, options);

			// Complex types
			WriteProp(writer, "agent", value.Agent, EcsJsonContext.Default.Agent, options);
			WriteProp(writer, "as", value.As, EcsJsonContext.Default.As, options);
			WriteProp(writer, "client", value.Client, EcsJsonContext.Default.Client, options);
			WriteProp(writer, "cloud", value.Cloud, EcsJsonContext.Default.Cloud, options);
			WriteProp(writer, "code_signature", value.CodeSignature, EcsJsonContext.Default.CodeSignature, options);
			WriteProp(writer, "container", value.Container, EcsJsonContext.Default.Container, options);
			WriteProp(writer, "data_stream", value.DataStream, EcsJsonContext.Default.DataStream, options);
			WriteProp(writer, "destination", value.Destination, EcsJsonContext.Default.Destination, options);
			WriteProp(writer, "device", value.Device, EcsJsonContext.Default.Device, options);
			WriteProp(writer, "dll", value.Dll, EcsJsonContext.Default.Dll, options);
			WriteProp(writer, "dns", value.Dns, EcsJsonContext.Default.Dns, options);
			WriteProp(writer, "elf", value.Elf, EcsJsonContext.Default.Elf, options);
			WriteProp(writer, "email", value.Email, EcsJsonContext.Default.Email, options);
			WriteProp(writer, "error", value.Error, EcsJsonContext.Default.Error, options);
			WriteProp(writer, "event", value.Event, EcsJsonContext.Default.Event, options);
			WriteProp(writer, "faas", value.Faas, EcsJsonContext.Default.Faas, options);
			WriteProp(writer, "file", value.File, EcsJsonContext.Default.File, options);
			WriteProp(writer, "geo", value.Geo, EcsJsonContext.Default.Geo, options);
			WriteProp(writer, "group", value.Group, EcsJsonContext.Default.Group, options);
			WriteProp(writer, "hash", value.Hash, EcsJsonContext.Default.Hash, options);
			WriteProp(writer, "host", value.Host, EcsJsonContext.Default.Host, options);
			WriteProp(writer, "http", value.Http, EcsJsonContext.Default.Http, options);
			WriteProp(writer, "interface", value.Interface, EcsJsonContext.Default.Interface, options);
			WriteProp(writer, "macho", value.Macho, EcsJsonContext.Default.Macho, options);
			WriteProp(writer, "network", value.Network, EcsJsonContext.Default.Network, options);
			WriteProp(writer, "observer", value.Observer, EcsJsonContext.Default.Observer, options);
			WriteProp(writer, "orchestrator", value.Orchestrator, EcsJsonContext.Default.Orchestrator, options);
			WriteProp(writer, "organization", value.Organization, EcsJsonContext.Default.Organization, options);
			WriteProp(writer, "os", value.Os, EcsJsonContext.Default.Os, options);
			WriteProp(writer, "package", value.Package, EcsJsonContext.Default.Package, options);
			WriteProp(writer, "pe", value.Pe, EcsJsonContext.Default.Pe, options);
			WriteProp(writer, "process", value.Process, EcsJsonContext.Default.Process, options);
			WriteProp(writer, "registry", value.Registry, EcsJsonContext.Default.Registry, options);
			WriteProp(writer, "related", value.Related, EcsJsonContext.Default.Related, options);
			WriteProp(writer, "risk", value.Risk, EcsJsonContext.Default.Risk, options);
			WriteProp(writer, "rule", value.Rule, EcsJsonContext.Default.Rule, options);
			WriteProp(writer, "server", value.Server, EcsJsonContext.Default.Server, options);
			WriteProp(writer, "service", value.Service, EcsJsonContext.Default.Service, options);
			WriteProp(writer, "source", value.Source, EcsJsonContext.Default.Source, options);
			WriteProp(writer, "threat", value.Threat, EcsJsonContext.Default.Threat, options);
			WriteProp(writer, "tls", value.Tls, EcsJsonContext.Default.Tls, options);
			WriteProp(writer, "url", value.Url, EcsJsonContext.Default.Url, options);
			WriteProp(writer, "user", value.User, EcsJsonContext.Default.User, options);
			WriteProp(writer, "user_agent", value.UserAgent, EcsJsonContext.Default.UserAgent, options);
			WriteProp(writer, "vlan", value.Vlan, EcsJsonContext.Default.Vlan, options);
			WriteProp(writer, "volume", value.Volume, EcsJsonContext.Default.Volume, options);
			WriteProp(writer, "vulnerability", value.Vulnerability, EcsJsonContext.Default.Vulnerability, options);
			WriteProp(writer, "x509", value.X509, EcsJsonContext.Default.X509, options);
			WriteProp(writer, "metadata", value.Metadata, options);

			if (typeof(EcsDocument) != value.GetType())
				value.WriteAdditionalProperties((k, v) => WriteProp(writer, k, v, options));
			writer.WriteEndObject();
		}
	}
}