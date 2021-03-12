using UnityEngine;

namespace Gameplay
{
    public class MouseRotator : MonoBehaviour
    {
        [SerializeField] private float speedX = 10f;
        [SerializeField] private float speedY = 10f;
        [SerializeField] private Transform transformPoint;

        private void Update()
        {
            if (!Input.GetMouseButton(0)) return;
            var x = speedX * Input.GetAxis("Mouse X");
            var y = speedY * Input.GetAxis("Mouse Y");
            var position = transformPoint.position;
        
            transformPoint.RotateAround(position, transform.transform.up, x);
            transformPoint.RotateAround(position, transform.transform.right, y);
        }

        public Transform RotateTransform => transformPoint;
    }
}
