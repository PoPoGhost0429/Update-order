using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class U2 : MonoBehaviour, IUpdatable{

    bool ed = true;
    [SerializeField] int excuteOrder=1;
    void Start(){
        UpdateManager manager = FindObjectOfType<UpdateManager>();
        manager.Register(this);
    }

    public void CustomUpdate(){
        // 這裡是原本的 Update 內容
        if(ed){
            Debug.Log("Second Update");
            ed = !ed;
        }
    }
    public int GetOrder(){
        return excuteOrder;
    }
}
