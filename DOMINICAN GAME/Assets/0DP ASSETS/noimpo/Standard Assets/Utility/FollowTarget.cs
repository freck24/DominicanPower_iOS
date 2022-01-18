using System;
using UnityEngine;


namespace UnityStandardAssets.Utility
{
    public class FollowTarget : MonoBehaviour
    {
        public bool SetParentNull;
        public Transform target;
        public Vector3 offset = new Vector3(0f, 7.5f, 0f);

        private void Start()
        {
            if (SetParentNull)
            {
                transform.SetParent(null);
                gameObject.SetActive(false);
            }
        }

        private void LateUpdate()
        {
            transform.position = target.position + offset;
        }
    }
}
