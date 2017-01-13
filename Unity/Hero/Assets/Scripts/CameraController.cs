using UnityEngine;

public class CameraController : MonoBehaviour {
	
    [SerializeField]
    private GameObject _target;
    private Vector3 _offset;

    void Start() {
        _offset = transform.position - _target.transform.position;
    }

    void LateUpdate() {
        transform.position = _target.transform.position + _offset;
    }
}