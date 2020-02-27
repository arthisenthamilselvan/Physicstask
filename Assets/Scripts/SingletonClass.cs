using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SingletonClass : MonoBehaviour
{
    private static SingletonClass instance;

    public static SingletonClass Instance {
        get {
            if (instance==null) {
                instance = new SingletonClass();
                return instance;
            }
            return instance;
        }
    }
}
