using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EliezerYT.UIAdjust
{ 
    public class UIA_Item : MonoBehaviour
    {
        public string KeyName;

        public Vector2 Actual_Pos;
        public Vector2 Actual_Scale;

        public Vector2 Default_Pos;
        public Vector2 Default_Scale;

        public void GetDefault()
        {
            Default_Pos = transform.localPosition;
            Default_Scale = transform.localScale;
        }

        public void SetDefault()
        {
            transform.localPosition = Default_Pos;
            transform.localScale = Default_Scale;
        }

        #region Save & Load
        public void Save()
        {
            PlayerPrefs.SetFloat("UIA_" + KeyName + "PosX", transform.localPosition.x);
            PlayerPrefs.SetFloat("UIA_" + KeyName + "PosY", transform.localPosition.y);
            PlayerPrefs.SetFloat("UIA_" + KeyName + "Scale", transform.localScale.x);
        }

        public void Load()
        {
            Vector2 _Pos = Vector2.zero;
            Vector2 _Scale = Vector2.zero;

            _Pos.x = PlayerPrefs.GetFloat("UIA_" + KeyName + "PosX", Default_Pos.x);
            _Pos.y = PlayerPrefs.GetFloat("UIA_" + KeyName + "PosY", Default_Pos.y);

            _Scale.x = PlayerPrefs.GetFloat("UIA_" + KeyName + "Scale", Default_Pos.x);
            _Scale.y = PlayerPrefs.GetFloat("UIA_" + KeyName + "Scale", Default_Pos.x);


            transform.localPosition = _Pos;
            transform.localScale = _Scale;
        }

        public void Reset()
        {
            transform.localPosition = Default_Pos;
            transform.localScale = Default_Scale;
        }

        #endregion

    }

}
