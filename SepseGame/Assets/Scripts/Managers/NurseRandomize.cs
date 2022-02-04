using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NurseRandomize : MonoBehaviour
{
    public NurseManage nm;

    public void Randomize() {
        nm.Generate();
    }
}
