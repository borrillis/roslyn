﻿namespace Microsoft.CodeAnalysis
{
    public static class WellKnownDiagnosticTags
    {
        /// <summary>
        /// Indicates that the diagnostic is related to some unnecessary source code.
        /// </summary>
        public const string Unnecessary = "Unnecessary";

        /// <summary>
        /// Indicates that the diagnostic is related to edit and continue.
        /// </summary>
        public const string EditAndContinue = "EditAndContinue";

        /// <summary>
        /// Indicates that the diagnostic is related to build.
        /// </summary>
        public const string Build = "Build";

        /// <summary>
        /// Indicates that the diagnostic can be used for telemetry
        /// </summary>
        public const string Telemetry = "Telemetry";

        /// <summary>
        /// Indicates that the diagnostic is not configurable in the ruleset editor.
        /// </summary>
        public const string NotConfigurable = "NotConfigurable";
    }
}
