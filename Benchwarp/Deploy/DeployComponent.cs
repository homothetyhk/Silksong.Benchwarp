using UnityEngine;

namespace Benchwarp.Deploy
{
    internal class DeployComponent : MonoBehaviour
    {
        private static DeployComponent? instance;

        private void Awake()
        {
            if (instance)
            {
                Destroy(instance!.gameObject);
            }
            instance = this;
        }

        private void OnDestroy()
        {
            if (instance == this)
            {
                instance = null;
            }
        }

        public static void DestroyAll()
        {
            if (instance) Destroy(instance!.gameObject);
        }
    }
}
