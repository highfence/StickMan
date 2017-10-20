using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierGenerator : MonoBehaviour
{
    bool _isEnemyGenerator = false;

    public void Init(Vector3 position, bool isEnemyGenerator)
    {
        this.transform.position = position;

        _isEnemyGenerator = isEnemyGenerator;
    }



}
