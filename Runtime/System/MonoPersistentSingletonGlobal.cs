using UnityEngine;

namespace com.Klazapp.Utility
{
    //Persistent Singleton - No explanation necessary
    public class MonoPersistentSingletonGlobal<T> : MonoBehaviour where T : Component
    {
        private static T instance;

        public static T Instance
        {
            get
            {
                if (instance != null)
                    return instance;
                
                instance = FindObjectOfType<T>();

                if (instance != null) 
                    return instance;
                    
                var obj = new GameObject
                {
                    name = typeof(T).Name
                };
                
                instance = obj.AddComponent<T>();

                return instance;
            }
        }

        protected virtual void Awake()
        {
            if (instance == null)
            {
                instance = this as T;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(gameObject);
            }

            //Custom post awake
            PostAwake();
        }

        //Custom post awake function
        protected virtual void PostAwake()
        {
            
        }
    }
}