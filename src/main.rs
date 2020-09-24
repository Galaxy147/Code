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
    println!("num1 = {0}", num1);

    let b = ['/', 'G', 'A', 'L', 'A', 'X', 'Y'];
    let mut i = 0;
    let location = loop
    {
        let ch = b[i];
        if ch == 'X' {
            break i;
        }
        i += 1;
    };
    println!("location is :{0}", location);
    let mut s1 = String::from("Hello");
    let s2 = s1.clone();
    println!("s1 = {0},s2 = {1}", s1,s2);
    let s2 = &mut s1;
    s2.push_str("Runoob");
}



