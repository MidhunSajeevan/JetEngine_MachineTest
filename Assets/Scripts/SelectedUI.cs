using UnityEngine;
using UnityEngine.UI; // Import UnityEngine.UI for the Image class

public class SelectedUI : MonoBehaviour
{
    Image targetImage; 
    public Sprite[] newImageSprite; 
    // Start is called before the first frame update
    void Start()
    {
        // Get the Image component from the GameObject this script is attached to
        targetImage = GetComponent<Image>();
        targetImage.sprite = newImageSprite[0];
    }

    public void ChangeImage(int val)
    {
        if (targetImage != null && newImageSprite != null)
        {
            targetImage.sprite = newImageSprite[val];
        }
        else
        {
            Debug.LogError("Target Image or New Image Sprite is not set.");
        }
    }
    
}
