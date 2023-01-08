using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace InGame.UI
{
    public static class UIHelper
    {
        public static void Clear(Transform content)
        {
            int toRemove = content.childCount;
            for (int i = 0; i < toRemove; i++)
            {
                GameObject.DestroyImmediate(content.GetChild(0).gameObject);
            }
        }
        public static void Refresh<TUILot, TModel>(TUILot prefab, Transform parent, IEnumerable<TModel> models, Action<TUILot, TModel> refreshFunc) where TUILot : MonoBehaviour
        {
            int diff = models.Count() - parent.childCount;

            // Add new lots if needed
            for (int i = 0; i < diff; i++)
            {
                GameObject.Instantiate(prefab, parent);
            }

            // Remove lots if needed
            for (int i = 0; i < -diff; i++)
            {
                GameObject.DestroyImmediate(parent.GetChild(0).gameObject);
            }

            int index = 0;
            foreach (TModel model in models)
            {
                refreshFunc(parent.GetChild(index).GetComponent<TUILot>(), model);
                index++;
            }
        }

        public static void FillWithInstance<TModel, TInstance>(Transform parent, IEnumerable<TModel> models, TInstance activeInstance, Action<TInstance, TModel> refreshFunc) where TInstance : MonoBehaviour
        {
            activeInstance.gameObject.SetActive(true);

            foreach (TModel model in models)
            {
                GameObject inst = GameObject.Instantiate(activeInstance.gameObject, parent);
                refreshFunc(inst.GetComponent<TInstance>(), model);
            }

            activeInstance.gameObject.SetActive(false);
        }
        public static void AppendWithInstance<TModel, TInstance>(Transform parent, TModel model, TInstance activeInstance, Action<TInstance, TModel> refreshFunc) where TInstance : MonoBehaviour
        {
            activeInstance.gameObject.SetActive(true);

            GameObject inst = GameObject.Instantiate(activeInstance.gameObject, parent);
            refreshFunc(inst.GetComponent<TInstance>(), model);

            activeInstance.gameObject.SetActive(false);
        }
    }
}