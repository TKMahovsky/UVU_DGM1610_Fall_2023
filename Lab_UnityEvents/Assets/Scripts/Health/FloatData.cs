using UnityEngine;

namespace Health
{
    [CreateAssetMenu]
    public class FloatData : ScriptableObject
    {
        public float value;

        public void UpdateValue(float num)
        {
            value += num;
        }
    }
}
