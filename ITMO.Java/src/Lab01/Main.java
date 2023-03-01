package Lab01;

import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        // Ex01
        System.out.println("Я");
        System.out.println("хорошо");
        System.out.println("знаю");
        System.out.println("Java.");

        // Ex02
        double res01Ex02 = (46 + 10) * (10d / 3);
        int res02Ex02 = 29 * 4 * -15;
        System.out.println(res01Ex02);
        System.out.println(res02Ex02);

        // Ex03
        int number = 10500;
        double res01Ex03 = (number / 10d) / 10;
        System.out.println(res01Ex03);

        // Ex04
        double firstNumber = 3.6;
        double secondNumber = 4.1;
        double thirdNumber = 5.9;
        double res01Ex04 = firstNumber * secondNumber * thirdNumber;
        System.out.println(res01Ex04);

        // Ex05
        Scanner sc = new Scanner(System.in);
        System.out.println("Введите 42:");
        int num1 = sc.nextInt();
        System.out.println("Введите 100:");
        int num2 = sc.nextInt();
        System.out.println("Введите 125:");
        int num3 = sc.nextInt();
        System.out.println(num1 + "\n" + num2 + "\n" + num3);

        // Ex06
        System.out.println("Введите целое число:");
        int num4 = sc.nextInt();
        if (num4 % 2 == 0 && num4 <= 100){
            System.out.println("Четное");
        } else if (num4 % 2 == 0 && num4 > 100) {
            System.out.println("Выход за пределы диапазона");
        }
        else {
            System.out.println("Нечетное");
        }
    }
}