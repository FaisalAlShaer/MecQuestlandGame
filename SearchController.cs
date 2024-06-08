using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SearchController : MonoBehaviour
{
    public GameObject bookCanvas;
    public InputField searchInputField;
    public Text resultsText;

    private Dictionary<string, string> departmentLocations = new Dictionary<string, string>()
    {

        //Akz building Ground Floor - 20f20646:

        {"main reception","Go to AKZ Building Ground Floor"},
        {"security services office", "Go to AKZ Building Ground Floor"},
        {"media communication and admission department", "Go to AKZ Building Ground Floor"},
        {"admision office", "Go to AKZ Building Ground Floor"},
        {"international office", "Go to AKZ Building Ground Floor"},
        {"accounts department", "Go to AKZ Building Ground Floor"},
        {"registration department", "Go to AKZ Building Ground Floor"},
        {"student success system", "Go to AKZ Building Ground Floor"},
        {"student experience office", "Go to AKZ Building Ground Floor or AKH First Floor"},
        {"foss lab", "Go to AKZ Building Ground Floor"},
        {"multimedia lab", "Go to AKZ Building Ground Floor"},
        {"multimedia studio", "Go to AKZ Building Ground Floor"},
        {"wellness center", "Go to AKZ Building Ground Floor"},

        //Akz First Floor
        {"hod - department of mathematics", "Go to AKZ Building First Floor"},
        {"hod - department of mathematics and applied science", "Go to AKZ Building First Floor"},
        {"hod - department of mechanical engineering", "Go to AKZ Building First Floor"},
        {"maintenance and house keeping office", "Go to AKZ Building First Floor"},
        {"procurment office", "Go to AKZ Building First Floor"},
        {"center of academic practices", "Go to AKZ Building First Floor"},
        {"associate dean - academic affaris", "Go to AKZ Building First Floor"},
        {"it services lab", "Go to AKZ Building First Floor"},
        {"gfp lab", "Go to AKZ Building First Floor"},
        {"database lab", "Go to AKZ Building First Floor"},
        {"network security lab", "Go to AKZ Building First Floor"},
        {"software lab", "Go to AKZ Building First Floor"},

        //AKZ Second Floor
        {"hod - department of civil engineering", "Go to AKZ Building Second Floor"},
        {"student advisory council office", "Go to AKZ Building Second Floor"},
        {"mathematics lab", "Go to AKZ Building Second Floor"},
        {"networking lab", "Go to AKZ Building Second Floor"},
        {"math referral lab", "Go to AKZ Building Second Floor"},
        {"hardware lab", "Go to AKZ Building Second Floor"},

        //AKH Building Ground floor
        {"human resources department", "Go to AKH Building Ground Floor"},
        {"general lab", "Go to AKH Building Ground Floor"},
        {"project lab", "Go to AKH Building Ground Floor"},
        {"library lab", "Go to AKH Building Ground Floor"},
        {"head of it services office", "Go to AKH Building Ground Floor"},

        //AKH Building First Floor
        {"executive offices", "Go to AKH Building First Floor"},
        {"managing directors office", "Go to AKH Building First Floor"},
        {"dean's office", "Go to AKH Building First Floor"},
        {"dean office", "Go to AKH Building First Floor"},
        {"deputy dean and registers office", "Go to AKH Building First Floor"},
        {"deapartment of planning and development", "Go to AKH Building First Floor"},
        {"quality assurance office", "Go to AKH Building First Floor"},
        {"software development and services", "Go to AKH Building First Floor"},
        {"data office", "Go to AKH Building First Floor"},
        {"pg study suite", "Go to AKH Building First Floor"},
        {"board Room", "Go to AKH Building First Floor"},
        {"huddle Room", "Go to AKH Building First Floor"},

        //IBK Building Ground Floor
        {"department of computing", "Go to IBK Building Ground Floor"},
        {"department of management studies", "Go to IBK Building Ground Floor"},
        {"department of mathematics and applied sciences", "Go to IBK Building Ground Floor"},
        {"rma", "Go to IBK Building Ground Floor"},
        {"briska cafe", "Go to IBK Building Ground Floor"},
        {"men prayer room", "Go to IBK or IBR or Student Hub Buildings Ground Floor"},

        //IBK Building First Floor
        {"department of civil engineering", "Go to IBK Building First Floor"},
        {"department of mechanical engineering", "Go to IBK Building First Floor"},
        {"department of records management and archival studies", "Go to IBK Building First Floor"},
        {"staff lounge", "Go to IBK Building First Floor"},
        {"ladies prayer room", "Go to IBK Building First Floor or Student Hub Ground Floor or IBR First Floor"},

        //Mechanical engineering building
        {"mechanical engineering lab", "Go to Mechanical Engineering Building Ground Floor"},

        //Student Hub building ground floor
        {"campus services office", "Go to Student Hub Building Ground Floor"},
        {"auditorium", "Go to Student Hub Building Ground Floor"},
        {"sport hall", "Go to Student Hub Building Ground Floor"},
        {"gym", "Go to Student Hub Building Ground Floor"},
        {"food court", "Go to Student Hub Building Ground Floor"},
        {"stationery shop", "Go to Student Hub Building Ground Floor"},
        {"student lounge", "Go to Student Hub Building Ground Floor"},

        //Student Hub First floor

        {"community outreach and activities department", "Go to Student Hub Building First Floor"},
        {"career services", "Go to Student Hub Building First Floor"},
        {"student accomodation and estates department", "Go to Student Hub Building First Floor"},

        //IBR Building ground floor
        { "health and safety office"," Go to IBR Building Ground Floor" },
        { "civil engineering labs"," Go to IBR Building Ground Floor" },
        { "poseia Cafe"," Go to IBR Building Ground Floor" },

        //IBR FIRST FLOOR
        { "center of foundation studies"," Go to IBR Building First Floor" },
        { "ishbilya cafe" ," Go to IBR Building First Floor" },
        { "call labs"," Go to IBR Building First Floor" },
        
        //IBR Second Floor
        { "associate dean reseach and innovation"," Go to IBR Building Second Floor" },
        { "department of electronics and communication engineering"," Go to IBR Building Second Floor" },
        { "center of academic writing"," Go to IBR Building Second Floor" },
        { "electronics and communication engineering labs"," Go to IBR Building Second Floor" },
        
    };

    void Start()
    {
        Debug.Log("Start method is running"); // Check if Start is running
        bookCanvas.SetActive(false);
    }

    void Update()
    {
        Debug.Log("Update method is running"); // Check if Update is running

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            Debug.Log("Tab key pressed"); // Check if Tab key is detected
            bookCanvas.SetActive(!bookCanvas.activeSelf);
        }
    }

    public void OnSearchButtonClicked()
    {
        string query = searchInputField.text.ToLower();
        if (departmentLocations.ContainsKey(query))
        {
            resultsText.text = departmentLocations[query];
        }
        else
        {
            resultsText.text = "Location not found. Please try another search.";
        }
    }
}
