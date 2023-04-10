int[] Size_array(int size, int minv, int maxv){
    int[] array= new int[size];
    for (int i=0; i<size;i++){
        array[i]=new Random().Next(minv,maxv);
    }
    return array;
}
int difference(int[] array){
    int min=array[0];
    int max=array[0];
    foreach(int el in array){
    if (el<min){
        min=el;}
    else if (el>max){
        max=el;}}
    return (max-min);
}
int[] array=Size_array(5,10,100);  
Console.WriteLine(difference(array));
Console.Write(String.Join(", ", array));