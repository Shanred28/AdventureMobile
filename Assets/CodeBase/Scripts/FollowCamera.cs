using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] private Transform _target;

    private void LateUpdate()
    {
        if(_target == null) return;

        transform.position = _target.transform.position;
    }

    public void SetTarget(Transform target)
    { 
        _target = target;
    }
}
