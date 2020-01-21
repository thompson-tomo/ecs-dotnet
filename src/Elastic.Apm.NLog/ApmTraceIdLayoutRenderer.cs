﻿using System.Text;
using NLog;
using NLog.Config;
using NLog.LayoutRenderers;

namespace Elastic.Apm.NLog
{
	[LayoutRenderer("ElasticApmTraceId")]
	[ThreadSafe]
	public class ApmTraceIdLayoutRenderer : LayoutRenderer
	{
		protected override void Append(StringBuilder builder, LogEventInfo logEvent)
		{
			if (!Agent.IsConfigured) return;
			if (Agent.Tracer.CurrentTransaction == null) return;

			builder.Append(Agent.Tracer.CurrentTransaction.TraceId);
		}
	}
}