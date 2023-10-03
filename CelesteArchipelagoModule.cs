using Microsoft.Xna.Framework;
using System;

namespace Celeste.Mod.CelesteArchipelago
{
    public class CelesteArchipelagoModule : EverestModule
    {
        public static CelesteArchipelagoModule Instance { get; private set; }

        public override Type SettingsType => typeof(CelesteArchipelagoModuleSettings);
        public static CelesteArchipelagoModuleSettings Settings => (CelesteArchipelagoModuleSettings)Instance._Settings;

        public override Type SessionType => typeof(CelesteArchipelagoModuleSession);
        public static CelesteArchipelagoModuleSession Session => (CelesteArchipelagoModuleSession)Instance._Session;

        public CelesteArchipelagoModule()
        {
            Instance = this;
#if DEBUG
            // debug builds use verbose logging
            Logger.SetLogLevel(nameof(CelesteArchipelagoModule), LogLevel.Verbose);
#else
            // release builds use info logging to reduce spam in log files
            Logger.SetLogLevel(nameof(CelesteArchipelagoModule), LogLevel.Info);
#endif
        }

        public override void Load()
        {
            // TODO: apply any hooks that should always be active
        }

        public override void Unload()
        {
            // TODO: unapply any hooks applied in Load()
        }
    }
}