 <?php
 if ($_FILES["file"]["error"] > 0)
	 {  // ������ �ִ��� �˻��ϴ� ����
         echo "Return Code: " . $_FILES["file"]["error"] . "<br>";  // ������ ������ � �������� �����
     } 
 else 
	 {   // ������ ���ٸ�
         echo "���� �̸�: " . $_FILES["file"]["name"] . "<br>";  // ���۵� ������ ���� �̸� ��
         echo "����: " . $_FILES["file"]["type"] . "<br>";   // ���۵� ������ ����(type)
         echo "���� �뷮: " . ($_FILES["file"]["size"]) . " Byte<br>";   // ���۵� ������ �뷮(�⺻ byte ��)
	if($_FILES["file"]["size"] > 51428800) echo "50MB�� �Ѵ� ������ ÷���� �� �����ϴ�";
	else
	{
		if (file_exists("upload/" . $_FILES["file"]["name"])) 
		{   // ���� �̸��� ������ �����ϴ��� üũ�� ��
			echo $_FILES["file"]["name"] . " ������ ������ �ֽ��ϴ�. ";    // ���� ������ �ִٸ� "������ ������ �ֽ��ϴ�"�� ���
		} 
		else 
		{    //  ������ ������ ���ٸ�
			move_uploaded_file($_FILES["file"]["tmp_name"], "file/" . $_FILES["file"]["name"]);
			// upload ������ ������ �����Ŵ
			echo "������ ����� ���� <strong>http://server.itsc.kr/upload" . "/file/" . $_FILES["file"]["name"] . "</strong>";   // upload ������ ����� ������ ����
		}
	}
 }
?>

