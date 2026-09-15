namespace SVprueba.Pages;

public class Calculadora
{
    //Se supone que es crops pero me equivoque
    public int CostoTotal (Cultivo props, int cantidadSemillas)
    {
        if (props == null || cantidadSemillas <= 0)
        {
            return 0;
        }
        else
        {
            return cantidadSemillas * props.cost;            
        }
    }
}