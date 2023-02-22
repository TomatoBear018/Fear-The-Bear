using UnityEngine;

namespace _Script.Movement
{
    public class CenterOrbiterMouse2D
    {
        public Vector2 basePos;
        public Vector2 currentPos;

        public CenterOrbiterMouse2D(GameObject gameObject)
        {
            basePos = gameObject.transform.position;
            currentPos = basePos;
        }

        public Vector2 OrbitBasedOnMouse(Vector2 mousePos, float percent)
        {
            Vector2 displacement = mousePos - basePos;
            float angle = Mathf.Atan2(displacement.y, displacement.x);
            float radius = displacement.magnitude;
            var x = Mathf.Cos(angle) * radius * percent;
            var y = Mathf.Sin(angle) * radius * percent;
            currentPos.x = x + basePos.x;
            currentPos.y = y + basePos.y;
            return currentPos;
        }
    }
}