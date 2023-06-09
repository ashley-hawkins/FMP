using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FMP
{
    public class ItemManager : MonoBehaviour
    {
        public static ItemManager instance;
        public ItemBase[] Items;

        private void Awake()
        {
            if (instance != null)
            {
                Destroy(gameObject);
                return;
            }
            instance = this;
        }

        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
