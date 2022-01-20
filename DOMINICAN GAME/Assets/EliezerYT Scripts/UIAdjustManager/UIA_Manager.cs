using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

namespace EliezerYT.UIAdjust
{

    public class UIA_Manager : MonoBehaviour
    {
        [Header("Base")]
          public bool ActiveSystem;
        [HideInInspector] bool Moving;
        UIA_Item Selected_Element;

        [Header("Parents")]
        public GameObject GroupOriginal;
        public GameObject GroupEditable;


        [Space(5)]
        [Header("Elements")]
        public List<Transform> UI_Elements;
        [HideInInspector] public List<UIA_Item> UI_Items;

        [Header("Editor Elements")]
        public List<Transform> UI_ElementsEditor;
        [HideInInspector] public List<UIA_Item> UI_ItemsEditor;

        [Header("Sliders")]
        public Slider ScaleModifier;

        private void Start()
        {
         Initialize();
        }

        public void ModifySystem(bool enabled)
        {
            ActiveSystem = enabled;
            GroupOriginal.SetActive(!enabled);
            GroupEditable.SetActive(enabled);
        }
        public void Initialize()
        {
            for (int i = 0; i < UI_Elements.Count; i++)
            {
                UIA_Item _item = UI_Elements[i].gameObject.AddComponent<UIA_Item>();
                string Name = UI_Elements[i].gameObject.name +"_" +  i;
                Name.Replace(" ", "_");
                _item.KeyName = Name;
                _item.GetDefault();
                UI_Items.Add(_item);

                UIA_Item _item2 = UI_ElementsEditor[i].gameObject.AddComponent<UIA_Item>();
                _item2.KeyName = Name;
                _item2.GetDefault();
                UI_ItemsEditor.Add(_item2);

                All_Load();
              //  All_Load2();
            }



        }


        private void Update()
        {
            if (!ActiveSystem) return;
            TouchMove_Manager();
        }


        public void All_Load()
        {
            for (int i = 0; i < UI_Items.Count; i++) UI_Items[i].Load();
        }

        public void All_Save()
        {
            for (int i = 0; i < UI_Items.Count; i++) UI_Items[i].Save();
        }
        public void All_Reset()
        {
            for (int i = 0; i < UI_ItemsEditor.Count; i++) UI_ItemsEditor[i].Reset();
        }

        public void All_Load2()
        {
            for (int i = 0; i < UI_ItemsEditor.Count; i++) UI_ItemsEditor[i].Load();
        }

        public void All_Save2()
        {
            for (int i = 0; i < UI_ItemsEditor.Count; i++) UI_ItemsEditor[i].Save();
            All_Load();
        }
        public void All_Reset2()
        {
            for (int i = 0; i < UI_ItemsEditor.Count; i++) UI_ItemsEditor[i].Reset();
        }


        public void TouchMove_Manager()
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (EventSystem.current.IsPointerOverGameObject())
                {
                    GameObject _obj = EventSystem.current.currentSelectedGameObject;
                    print("clicked on: " + _obj.name);
                    if (_obj.tag == "EliezerYT/UIA_Editable")
                    {
                        Moving = true;
                        Selected_Element = _obj.GetComponent<UIA_Item>();
                        ScaleModifier.value = _obj.transform.localScale.x;
                    }
                }
            }

                    if(Moving)
                    {
                        Vector2 movePos;

                        RectTransformUtility.ScreenPointToLocalPointInRectangle(
                        GetComponentInParent<Canvas>().transform as RectTransform,
                        Input.mousePosition, GetComponentInParent<Canvas>().worldCamera,
                        out movePos);

                        Selected_Element.transform.position = GetComponentInParent<Canvas>().transform.TransformPoint(movePos);
                    }

                    if (Input.GetMouseButtonUp(0)) Moving = false;
                }

        public void ChangeScale(Slider _slider) => Selected_Element.transform.localScale = new Vector2(_slider.value, _slider.value);
        }
}
