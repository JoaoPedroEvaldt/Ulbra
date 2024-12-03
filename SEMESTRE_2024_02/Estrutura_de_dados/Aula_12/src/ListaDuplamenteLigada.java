public class ListaDuplamenteLigada <T> {
    private  No<T> inicio;
    private No <T> fim;

    public  ListaDuplamenteLigada(){
        this.inicio = null;
        this.fim = null;
    }

    public void adicionarNoIncio ( T dado){
        No <T> novoNo = new No<>(dado);

        if(inicio == null){ // verifica se a lista está vazia
            inicio = novoNo;
            fim = novoNo;
        }else{ // Caso contenha elementos na lista
            fim.proximo = inicio;
            inicio.anterior = novoNo;
            inicio = novoNo;
        }
    }


}
