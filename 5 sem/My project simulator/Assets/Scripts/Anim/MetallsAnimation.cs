using UnityEngine;

public class MetallsAnimation : MonoBehaviour
{
    public enum Metalls
    {
        Swinez,
        Aluminium,
        Fe
    };

    public Metalls currMetall;
    [SerializeField] private TaskPanel _taskPanel;
    [SerializeField] private Animator _swinAnimation;
    [SerializeField] private Animator _aluminiumAnimation;
    [SerializeField] private Animator _feAnimation;

    private void Start()
    {
        currMetall = Metalls.Swinez;
        SetMetallAnimationAndText(Metalls.Swinez, "Свинец");
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                switch (hit.collider.gameObject.name)
                {
                    case "Aluminium":
                        SetMetallAnimationAndText(Metalls.Aluminium, "Алюминий");
                        break;

                    case "Fe":
                        SetMetallAnimationAndText(Metalls.Fe, "Железо");
                        break;

                    case "Swinez":
                        SetMetallAnimationAndText(Metalls.Swinez, "Свинец");
                        break;

                    default:
                        break;
                }
            }
        }
    }

    private void SetMetallAnimationAndText(Metalls metall, string text)
    {
        int animationValue = 0;
        switch (metall)
        {
            case Metalls.Aluminium:
                animationValue = 1;
                break;

            case Metalls.Fe:
                animationValue = 2;
                break;

            case Metalls.Swinez:
                animationValue = 3;
                break;

            default:
                break;
        }

        _swinAnimation.SetInteger("MetalIs", animationValue);
        _aluminiumAnimation.SetInteger("MetalIs", animationValue);
        _feAnimation.SetInteger("MetalIs", animationValue);
        currMetall = metall;
        _taskPanel.selectedCondText.text = text;
    }
}
