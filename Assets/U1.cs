using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class U1 : MonoBehaviour, IUpdatable{
    bool ed = true;
    [SerializeField] int excuteOrder=0;
    void Start(){
        UpdateManager manager = FindObjectOfType<UpdateManager>();
        manager.Register(this);
    }


    public void CustomUpdate(){
        // 這裡是原本的 Update 內容
        if(ed){
            Debug.Log("First Update");
            ed = !ed;
        }
    }

    public int GetOrder(){
        return excuteOrder;
    }
}

