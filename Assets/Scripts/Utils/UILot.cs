using UnityEngine;

namespace InGame.UI
{
    public abstract class UILot<T> : MonoBehaviour
    {
        protected T model;

        public void Refresh(T model)
        {
            this.model = model;
            Refresh();
        }
        protected abstract void Refresh();
    }
}