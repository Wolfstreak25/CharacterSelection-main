using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [System.Serializable]
    public class Tank
    {
        public float rotateSpeed;
        public float movementSpeed;
        public TankTypes tankType;
        public Material color;
    }

    public List<Tank>tankList;

    public TankView tankView;
    void Start()
    {
        CreateTank();
    }
    
    private void CreateTank()
    {
        TankModel tankModel = new TankModel(tankList[0].movementSpeed, tankList[0].rotateSpeed, tankList[0].tankType, tankList[0].color);

        TankController tankController = new TankController(tankModel, tankView);
    }

}
