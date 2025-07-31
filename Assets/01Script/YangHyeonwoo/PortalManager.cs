using UnityEngine;

public class PortalManager : MonoBehaviour
{
    private bool inactive;
    private bool _Cooltime;

    public bool Inactive
    {
        get { return inactive; }
        set { inactive = value; }
    }

    public bool CoolTime
    {
        get { return _Cooltime; }
        set { _Cooltime = value; }
    }
}