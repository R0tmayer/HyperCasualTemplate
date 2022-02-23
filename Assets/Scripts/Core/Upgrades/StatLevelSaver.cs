using UnityEngine;

namespace Core.Upgrades
{
    public class StatLevelSaver
    {
        private const string _powerLevelPrefsKey = nameof(_powerLevelPrefsKey);
        private const string _speedLevelPrefsKey = nameof(_speedLevelPrefsKey);
        private const string _armorLevelPrefsKey = nameof(_armorLevelPrefsKey);

        public int PowerLevel
        {
            get => PlayerPrefs.GetInt(_powerLevelPrefsKey, 0);
            set => PlayerPrefs.SetFloat(_powerLevelPrefsKey, value);
        }

        public int SpeedLevel
        {
            get => PlayerPrefs.GetInt(_speedLevelPrefsKey, 0);
            set => PlayerPrefs.SetFloat(_speedLevelPrefsKey, value);
        }

        public int ArmorLevel
        {
            get => PlayerPrefs.GetInt(_armorLevelPrefsKey, 0);
            set => PlayerPrefs.SetFloat(_armorLevelPrefsKey, value);
        }
    }
}