using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IUpdatable
{
    void CustomUpdate();
    int GetOrder();
}


public class UpdateManager : MonoBehaviour
{
    private List<IUpdatable> updatables = new List<IUpdatable>();

    public void Register(IUpdatable updatable){
        if (!updatables.Contains(updatable)){
            updatables.Add(updatable);
        }
    }

    void Update(){
        for (int i = 0; i < updatables.Count; i++){
            for(int j = 0; j < updatables.Count; j++){
                if(updatables[j].GetOrder() == i){
                    updatables[j].CustomUpdate();
                    break;
                }
            }
        }
    }
}


