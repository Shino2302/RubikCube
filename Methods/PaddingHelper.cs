namespace CubeRubikInArrays.PaddingHelper;

public class PaddingHelper
{
    public int CalculatePaddingRequired(string yourTextPlain)
    {
        if(!MinimumOfCharacters(yourTextPlain))
            return 0;
        else
            return 96 - yourTextPlain.Length;
    }

    public bool MinimumOfCharacters(string yourTextPlain)
    {
        if (yourTextPlain.Length < 8)
            return false;
        return true;
    }

    public string YourTextWhitPadding(string yourTextPlain)
    {
        int paddingRequired = CalculatePaddingRequired(yourTextPlain);
        if(paddingRequired == 0)
            return "Error, minimo requieres una cadena de 8 caracteres";
        for (int i = 0; i < paddingRequired; i++)
            yourTextPlain += Convert.ToChar(i + 33);
        return yourTextPlain;
    }
}
