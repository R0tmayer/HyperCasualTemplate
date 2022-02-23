// Generated automatically by DI Framework

using DELTation.DIFramework.Baking;
using UnityEngine;

namespace DI.Baked
{
    /// <summary>
    /// Baked injection data
    /// </summary>
    internal static class BakedInjectionData
    {
#if UNITY_EDITOR
        [UnityEditor.InitializeOnLoadMethod]
#else
        [RuntimeInitializeOnLoadMethod]
#endif
        public static void Bake()
        {
            BakedInjection.DataExists = true;
            BakedInjection.Clear();
            
            BakedInjection.Bake(typeof(Core.Vibrations.VibrationsReproducer), InstantiationFunction_0);
            BakedInjection.Bake(typeof(Core.Upgrades.Stat), InstantiationFunction_1);
            BakedInjection.Bake(typeof(Core.Upgrades.StatLevelSaver), InstantiationFunction_2);
            BakedInjection.Bake(typeof(Core.Upgrades.StatPresenter), InstantiationFunction_3);
            BakedInjection.Bake(typeof(Core.UI.ImageStateToggle), InjectionFunction_4);

        }

        private static object InstantiationFunction_0(PocoResolutionFunction resolve)
        {
            return new Core.Vibrations.VibrationsReproducer();
        }

        private static object InstantiationFunction_1(PocoResolutionFunction resolve)
        {
            return new Core.Upgrades.Stat();
        }

        private static object InstantiationFunction_2(PocoResolutionFunction resolve)
        {
            return new Core.Upgrades.StatLevelSaver();
        }

        private static object InstantiationFunction_3(PocoResolutionFunction resolve)
        {
            return new Core.Upgrades.StatPresenter();
        }

        private static void InjectionFunction_4(MonoBehaviour component, ResolutionFunction resolve)
        {
            var obj = (Core.UI.ImageStateToggle) component;
            obj.Construct((Core.Vibrations.VibrationsReproducer) resolve(component, typeof(Core.Vibrations.VibrationsReproducer)));
        }


    }
}
