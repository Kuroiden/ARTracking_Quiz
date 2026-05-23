using UnityEngine;

// T is a Generic Class that can be ANY MonoBehaviour
// <T> where T : MonoBehaviour
public abstract class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    public static T Instance { get; private set; }

    protected virtual void Awake()
    {
        // Check if there is already an Instance
        if (Instance != null && Instance != this as T)
        {
            // IF there is already an existing, destroy self
            // Isa lang pwede, wag nang ipagsisikan ang sarili. 
            Destroy(this.gameObject);
            return;
        }
        else
        {
            // assign self as the instance
            Instance = this as T;
            // make sure this gameobject (which is the instance) doesnt get destroyed when loading a level
            DontDestroyOnLoad(this.gameObject);
        }
    }
}