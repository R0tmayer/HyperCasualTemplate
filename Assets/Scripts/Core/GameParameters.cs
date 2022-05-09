using UnityEngine;

namespace Core
{
    [CreateAssetMenu(fileName = "Game Parameters", menuName = "ScriptableObjects/GameParameters", order = 1)]

    public class GameParameters : ScriptableObject
    {
        [SerializeField] private float _speed;

        public float Speed => _speed;
    }
}