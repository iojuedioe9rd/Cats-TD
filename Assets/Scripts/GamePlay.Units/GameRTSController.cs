using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

namespace GamePlay.Units
{
    public class GameRTSController : MonoBehaviour
    {
        private Vector3 startPos;
        private List<UnitRTS> units;

        private void Awake()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            if(Input.GetMouseButtonDown(0))
            {
                startPos = UtilsClass.GetMouseWorldPosition();
            }

            if(Input.GetMouseButtonUp(0))
            {
                Debug.Log($"{UtilsClass.GetMouseWorldPosition()} {startPos}");
                Collider2D[] unitsColliders = Physics2D.OverlapAreaAll(startPos, UtilsClass.GetMouseWorldPosition());
                Debug.Log("#######");
                foreach (Collider2D collider2D in unitsColliders)
                {
                    Debug.Log(collider2D);
                }
            }
        }
    }
}
