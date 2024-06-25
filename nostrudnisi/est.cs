public GameObject child;
public Transform parent;

public void SetParent(Transform newParent)
{
    child.transform.SetParent(newParent);
}
