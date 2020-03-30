using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death : MonoBehaviour
{
    public static death instance;
    public static death Instance()
    {
        if (instance == null)
        {
            instance = new death();
        }
        return instance;
    }
    public void dead()
    {
        Destroy(gameObject);
    }
}
