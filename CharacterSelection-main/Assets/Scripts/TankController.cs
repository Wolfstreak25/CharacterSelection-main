using UnityEngine;

public class TankController
{
    private TankView tankView;
    private TankModel tankModel;

    public TankController(TankModel _tankModel, TankView _tankView)
    {
        tankView = _tankView;
        tankModel = _tankModel;

        tankModel.SetTankController(this);
        tankView.SetTankController(this);

        GameObject.Instantiate(tankView.gameObject);
    }

}
