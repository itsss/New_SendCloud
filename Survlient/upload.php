 <?php
 if ($_FILES["file"]["error"] > 0)
	 {  // 에러가 있는지 검사하는 구문
         echo "Return Code: " . $_FILES["file"]["error"] . "<br>";  // 에러가 있으면 어떤 에러인지 출력함
     } 
 else 
	 {   // 에러가 없다면
         echo "파일 이름: " . $_FILES["file"]["name"] . "<br>";  // 전송된 파일의 실제 이름 값
         echo "형식: " . $_FILES["file"]["type"] . "<br>";   // 전송된 파일의 형식(type)
         echo "파일 용량: " . ($_FILES["file"]["size"]) . " Byte<br>";   // 전송된 파일의 용량(기본 byte 값)
	if($_FILES["file"]["size"] > 51428800) echo "50MB가 넘는 파일은 첨부할 수 없습니다";
	else
	{
		if (file_exists("upload/" . $_FILES["file"]["name"])) 
		{   // 같은 이름의 파일이 존재하는지 체크를 함
			echo $_FILES["file"]["name"] . " 동일한 파일이 있습니다. ";    // 같은 파일이 있다면 "동일한 파일이 있습니다"를 출력
		} 
		else 
		{    //  동일한 파일이 없다면
			move_uploaded_file($_FILES["file"]["tmp_name"], "file/" . $_FILES["file"]["name"]);
			// upload 폴더에 파일을 저장시킴
			echo "파일이 저장된 곳은 <strong>http://server.itsc.kr/upload" . "/file/" . $_FILES["file"]["name"] . "</strong>";   // upload 폴더에 저장된 파일의 내용
		}
	}
 }
?>

