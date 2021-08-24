using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_IOS

using Unity.Advertisement.IosSupport;
#endif 

public class IOSATTRequest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
#if UNITY_IOS
        if(ATTrackingStatusBinding.GetAuthorizationTrackingStatus() == ATTrackingStatusBinding.AuthorizationTrackingStatus.NOT_DETERMINED)
        {
            ATTrackingStatusBinding.RequestAuthorizationTracking();
        }
#endif
    }
}
