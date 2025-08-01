//using UnityEngine;

//public class PortalManager : MonoBehaviour
//{
//    public bool IsPlayerOnPortal { get; set; } = false;

//    private bool inactive;
//    private bool _Cooltime;

//    public bool Inactive
//    {
//        get { return inactive; }
//        set { inactive = value; }
//    }

//    public bool CoolTime
//    {
//        get { return _Cooltime; }
//        set { _Cooltime = value; }
//    }
//}

using UnityEngine;

public class PortalManager : MonoBehaviour
{
    public bool Cooldown { get; set; } = false;
}
