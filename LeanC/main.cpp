/*---------------------- Project -------------------------
		a student manage porgram
*/

#include <stdio.h>
#include <stdlib.h>
#include <fstream>
#include <ctime>

FILE* fp = fopen("usrconf.sif", "rw");

struct student
{
	int age;
	char* name[20];
	char* sex[1];
	int num[];
};

void Delay(int time);
int firstUse();
int genAccount();
void welcome(char* c_usrname, int i_class);
int login(char* c_usrname, char* c_passwd);
int verifyLogin(char* cI_usrname, char* cI_passwd);
char* lockString(char* c_str);
 
int main(int* argc[], char* argv[])
{
	int i;
	while (fgetc(fp+i))
	{
		i++;
	}
}

int firstUse()
{
	printf("Welcome!And thank you for using this program.");
	printf("Do you want to register your account now?\n\
			(1)Yes.\n\
			(2)Quit\n");
	while (true)
	{
		int i_choice;
		bool b_isVaild;

		printf("Choice:");
		switch (i_choice)
		{
		case 1:
			genAccount();
			break;
		case 2:
			break;
		default:
			printf("Is not a vaild choice.");
		} 
	}
	system("pause");
	return 0;
}

int genAccount()
{
	char cI_usrname[21];
	char cI_passwd[21];
	char cI_confirm[21];
	bool b_passwdSame;

	if (fp == NULL)
	{
		printf("Can\'t open the file.Exiting in 5 seconds...");
		return 0;
	}
	while (true)
	{
		int i_length;
		printf("Please input your usrname(<= 20 characters,no : ; | \\):");
		scanf_s("%s", cI_usrname);
		for (int i = 0; cI_usrname[i] = '\0'; i++)
		{
			if (cI_usrname[i] == ':' || ';' || '|' || '\\')
			{
				printf("Not a vaild username.");
			}
			if ((cI_usrname[i + 1] = '\0') && (cI_usrname[i] == ':' || ';' || '|' || '\\'))
			{
				break;
			}
		}
	}
	do
	{
		printf("Notice: Password can have characters(<= 20 characters,no : ; | \\)\n\
			Please input your password:");
		scanf_s("%s", cI_passwd);

		while (true)
		{
			printf("Notice: Password can have characters(<= 20 characters,no : ; | \\)\n\
			Please input your password:");
			scanf_s("%s", cI_passwd);
			for (int i = 0; cI_passwd[i] = '\0'; i++)
			{
				if (cI_passwd[i] == ':' || ';' || '|' || '\\')
				{
					printf("Not a vaild username.");
				}
				if ((cI_passwd[i + 1] = '\0') && (cI_passwd[i] == ':' || ';' || '|' || '\\'))
				{
					break;
				}
			}
		}

		printf("Confirm it:");
		scanf_s("%s", cI_confirm);
		for (int i = 0; i < 20; i++)
		{
			if (cI_passwd[i] == cI_confirm[i])
			{
				b_passwdSame = true;
				
				break;
			}
			else
			{
				printf("Passwd doesn't same,please try again.");
			}
		}
	} while (!b_passwdSame);
	fprintf(fp, "{:%s;%s|f}", lockString(cI_usrname), lockString(cI_passwd) );
	fclose(fp);
}

char* lockString(char* c_str) 
{
	for (int i = 0; i < strlen(c_str); i++)
	{
		c_str[i] = c_str[i] + 5 * 10 - 6;
	}
	return c_str;
}

void welcome(char* s_usrname, int i_class)
{
	printf("------------Welcome!,%c------------\n\
			\t\tClass:%i\n\
			(1)Add a student\n\
			(2)Save.\n\
			(3)Quit and save", s_usrname, i_class);
}

int login(char* c_usrname, int* i_passwd)
{
	printf("------------Login------------\n\
			Username:");
	scanf_s("%s", c_usrname);
	printf("Password:");
	scanf_s("%i", i_passwd);
}

void Delay(int time) 
{
	clock_t now = clock();

	while (clock() - now < time*1000);
}

int verifyLogin(char* cI_usrname, char* cI_passwd)
{
	bool b_usernameTrue;
	bool b_passwdTrue;
	char* c_trueUsrname;
	char* c_truePasswd;
	// There's a "usrconf.sif" at the "./"

	if (fp == NULL)
	{
		printf("Can't open user configuration file.Program will exit in 5 seconds...");
		Delay(5);
		return 0;
	}

	{int i = 0;  // A code block 
		while (char a = fgetc(fp + i) != EOF)
		{
			if (a == 'u')
			{
				i++;
				while (a != 'e')
				{
					int j;
					c_trueUsrname[i] = a;
					i++;
				}
			}
			else if (a == 'p')
			{
				i++;
				while (a != 'e')
				{
					int j;
					c_truePasswd[j - i] = a;
					j++;
				}
			}
			else
			{
				i++;
			}
		}
	}

	do
	{
		if (c_trueUsrname == cI_usrname)
		{
			b_usernameTrue = 1;
		}
		else
		{
			b_usernameTrue = 0;
		}
		if (c_truePasswd == cI_passwd)
		{
			b_passwdTrue = 1;
		}
		else
		{
			b_passwdTrue = 0;
		}
		if (b_usernameTrue && b_passwdTrue)
		{
			printf("The username and the password is correct.");
		}
		else if (b_usernameTrue && !b_passwdTrue)
		{
			printf("The password is incorrect!");
		}
		else if (!b_usernameTrue && b_passwdTrue)
		{
			printf("The username is incorrect");
		}
		else if (!b_usernameTrue && !b_passwdTrue)
		{
			printf("Username and passwd are incorrect");
		}
	} while (!(b_usernameTrue && b_passwdTrue));
}