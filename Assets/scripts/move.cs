using UnityEngine;

public class move : MonoBehaviour
{
    [SerializeField] ui Ui;
    [SerializeField] GameObject Body;
    [SerializeField] Transform BodyAngles;
    [SerializeField] buttons[] butt;
    float Speed;
    float Angle;
    int MaxSpeed = 3;
    float AngleStep = 0.3f;
    void Start()
    {
        Ui.Speed.text = $"{MaxSpeed} MaxSpeed";
        Ui.Angle.text = $"{AngleStep} AngleStep";
    }
    void Update()
    {
        if (butt[1].Press && Speed <= MaxSpeed)
        {
            Speed += Time.deltaTime;
            if (Speed > MaxSpeed) Speed = MaxSpeed;
            Angle = -AngleStep;
        }
        else
        {
            Speed -= Time.deltaTime;
            if (Speed < 0) Speed = 0;
            Angle = 0;
        }
        if (butt[0].Press && Speed < 0)
        {
            Speed -= Time.deltaTime;
            if (Speed < 0) Speed = 0;
            Angle = AngleStep;
        }
        Body.transform.position -= new Vector3(Speed * Time.deltaTime, 0, 0);
        BodyAngles.eulerAngles -= new Vector3(0, 0, Angle);
    }
    public void ChangeSpeed()
    {
        MaxSpeed++;
        if (MaxSpeed > 5) MaxSpeed = 1;
        Ui.Speed.text = $"{MaxSpeed} MaxSpeed";
    }
    public void ChangeAngle()
    {
        AngleStep += 0.1f;
        if (AngleStep > 0.5f) AngleStep = 0.1f;
        Ui.Angle.text = $"{AngleStep} AngleStep";
    }
}
