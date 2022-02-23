using MoreMountains.NiceVibrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Core.Vibrations
{
    public class VibrationsReproducer
    {
        private const string VibrationsPrefsKey = nameof(VibrationsPrefsKey);

        public bool Enabled
        {
            get => PlayerPrefs.GetInt(VibrationsPrefsKey, 1) == 1;
            set => PlayerPrefs.SetInt(VibrationsPrefsKey, value ? 1 : 0);
        }

        public void TryPlayHaptic(HapticTypes hapticTypes)
        {
            if (Enabled)
                MMVibrationManager.Haptic(hapticTypes);
        }
    }
}