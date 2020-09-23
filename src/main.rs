fn main()
{   
    let num = 3;
    let num1 = {
        num + 1
    };
    let a = if num > 0 {1} else {2};
    println!("{}" ,a);
    
    let a = [10,20,30,40,50];
    for i in a.iter() {
        println!("{}", i);
    }
    println!("num1 = {0}", num1)
}



