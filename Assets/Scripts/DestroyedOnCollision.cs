using UnityEngine;
using System.Collections.Generic;

public enum TagListType
{
    Blacklist,
    Whitelist
}

public class DestroyedOnCollision : MonoBehaviour
{
    [SerializeField] private TagListType tagListType = TagListType.Blacklist;
    [SerializeField] private List<string> tags = new List<string>();

    private void OnTriggerEnter2D(Collider2D other)
    {
        bool tagInList = tags.Contains(other.tag);

        bool shouldDestroy =
            (tagListType == TagListType.Blacklist && tagInList) ||
            (tagListType == TagListType.Whitelist && !tagInList);

        if (shouldDestroy)
        {
            Destroy(gameObject);
        }
    }
}