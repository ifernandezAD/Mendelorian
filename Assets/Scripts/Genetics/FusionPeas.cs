using UnityEngine;

public class FusionPeas : MonoBehaviour
{
    //Peas to merge and his phenotypes
    [SerializeField]
    GameObject[] peas;

    [SerializeField]
    string phenotype1;

    [SerializeField]
    string phenotype2;

    //Resulting genotype of the new pea
    [SerializeField]
    string genotype;

    public RandomPhenotype randomPhenotype;
    public bool isMerging = false;


    private void Update()
    {
        phenotype1 = peas[0].GetComponent<RandomPhenotype>().phenotype;
        phenotype2 = peas[1].GetComponent<RandomPhenotype>().phenotype;
        ObtainingGenotype();
    }


    string ObtainingGenotype()
    {
        if (phenotype1 == "AB" && phenotype2 =="AB")
        {
            genotype = "AABB";
        }
        if (phenotype1 == "AB" && phenotype2 == "Ab")
        {
            genotype = "AABb";
        }
        if (phenotype1 == "AB" && phenotype2 == "aB")
        {
            genotype = "AaBB";
        }
        if (phenotype1 == "AB" && phenotype2 == "ab")
        {
            genotype = "AaBb";
        }


        if (phenotype1 == "Ab" && phenotype2 == "AB")
        {
            genotype = "AABb";
        }
        if (phenotype1 == "Ab" && phenotype2 == "Ab")
        {
            genotype = "AAbb";
        }
        if (phenotype1 == "Ab" && phenotype2 == "aB")
        {
            genotype = "AaBb";
        }
        if (phenotype1 == "Ab" && phenotype2 == "ab")
        {
            genotype = "Aabb";
        }


        if (phenotype1 == "aB" && phenotype2 == "AB")
        {
            genotype = "AaBB";
        }
        if (phenotype1 == "aB" && phenotype2 == "Ab")
        {
            genotype = "AaBb";
        }
        if (phenotype1 == "aB" && phenotype2 == "aB")
        {
            genotype = "aaBB";
        }
        if (phenotype1 == "aB" && phenotype2 == "ab")
        {
            genotype = "aaBb";
        }

        if (phenotype1 == "ab" && phenotype2 == "AB")
        {
            genotype = "AaBb";
        }
        if (phenotype1 == "ab" && phenotype2 == "Ab")
        {
            genotype = "Aabb";
        }
        if (phenotype1 == "ab" && phenotype2 == "aB")
        {
            genotype = "aaBb";
        }
        if (phenotype1 == "ab" && phenotype2 == "ab")
        {
            genotype = "aabb";
        }


        return genotype;
    }
}
