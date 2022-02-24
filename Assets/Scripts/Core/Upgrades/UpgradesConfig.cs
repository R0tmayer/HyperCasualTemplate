using Sirenix.OdinInspector;
using UnityEngine;

namespace Core.Upgrades
{
    [CreateAssetMenu(fileName = "Upgrades Config", menuName = "Configs/Upgrades", order = 1)]

    public class UpgradesConfig : ScriptableObject
    {
        [TabGroup("Upgrades", "PowerList")]
        [SerializeField]
        [ListDrawerSettings(ShowIndexLabels = true)]
        private Stat[] _powerList;        
        
        [TabGroup("Upgrades", "SpeedList")]
        [SerializeField]
        [ListDrawerSettings(ShowIndexLabels = true)]
        private Stat[] _speedList;        
        
        [TabGroup("Upgrades", "ArmorList")]
        [SerializeField]
        [ListDrawerSettings(ShowIndexLabels = true)]
        private Stat[] _armorList;

        public Stat[] PowerList => _powerList;
        public Stat[] SpeedList => _speedList;
        public Stat[] ArmorList => _armorList;
    }
}