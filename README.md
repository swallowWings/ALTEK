# ALTEK is a data processing tool
ALTEK will help you processing ASCII rater files and text files.   
ALTEK can process a lot of files in a batch process. The main features of the ALTEK are as below.

  ![](https://github.com/swallowWings/ALTEK/blob/master/Wiki/MainGUI.JPG) 

O Raster files converter(using GDAL tool)
   - Convert GTiff files <-> ASCII raster files
   - Convert GRIB/GRIB2 files -> ASCII raster files
   - Convert NetCDF files -> ASCII raster files
   - Convert ASC raster files -> image files
   - Clip and resample ASCII raster files
   - Get raster files information

O ASCII raster calculator
   - Algebraic or conditional calculation of ASCII raster files

O Coordinate system converter(using GDAL tool)
   - Convert coordinate systems of a lot of files in a batch process

O Get values from text files
   - Extract values in a cell of ASCII raster files
   - Calculate average, min, max, sum values of ASCII raster files
   - Calculate average, min, max, sum values of all cells in ASCII raster files
   - Aggregate ASCII raster files in some interval   
   - Extract values in a certain column of text files

O Append text files 
   - Append text files in column mode
   - Append text files in row mode
  
O Text files editor
   - Replace text in the text files
   - Search and replace lines in the text files
   - Insert texts at a line index in the text files
   - Remove lines from the text files
   - Remove empty lines in the text files
   - Replace values in a certain region of the ASCII raster files
   - Cut decimal parts in the ASCII raster files
   - Set texts between texts in a line of the text files

O File name processor  
   - Rename files  
   - Rename files to DateTime format  
   - Copy files using the file name list  
   - Change the extensions of files  
   - Save file list (full path and name) to a file  
   - Make a batch file using file list  
   

# Using ALTEK
 - 파일 다운로드와 세팅 가이드는 https://github.com/swallowWings/ALTEK/tree/master/DownloadStableVersion   
   에서 gdal.zip과 ALTEK.*을 다운로드 하고, 각 파일의 속성(마우스 우클릭>속성)에서 차단해제 
 - 압축파일을 풀고, gdal 폴더는 ALTEK.exe와 같은 폴더에 배치해서 사용  
   (ex, d:\ALTEKtool\ALTEK.exe             
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; d:\ALTEKtool\ALTEK.exe.config  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; d:\ALTEKtool\gdal\ (gdal files.....)  
       
# Update history
O 2018   
 - Tok이라는 이름으로 처음 배포됨  
  - 모든 ascii 데이터가 소수점 2자리 까지 출력되는 현상 수정(원본 데이터들의 자리수 그대로 유지되게 수정)
 - raster calculator에서 버그 수정
 - 클리핑에서 실수형 셀사이즈 관련 버그 수정
 - extension filter 관련 버그 수정
 - converting format, resampling, clipping에서 xml 파일 안만들어지게 수정
 - Progress bar stop 기능 관련 수정  
 - Progress bar 버그 수정
 - Search and replace line by line 기능 추가
 - 텍스트 Line 추가 기능 추가
 - 라인 삭제 기능 추가
 - 파일 경로+이름 리스트 저장 기능 추가  
 - 래스터 범위에서 값 수정하는 기능 버그 수정
 - 래스터 값 소수점 자리수 줄이는 기능 추가
 - 래스터 계산기에서 소수점 자리수 지정하는 기능 추가
 - 매우 큰 텍스트 파일 처리 관련 오류 수정  
 - 여러개 밴드를 가지는 GeoTIFF 파일에서 밴드를 지정해서 ASCII 파일로 변환하는 기능 추가
 - 대용량 ascii 파일 적용 기능 확대
 - Img 파일 만들때 renderer 에서 depth renderer 추가
 - ASCII 파일을 image로 변환하는 기능 개선
 - Grib/Grib2 파일을 ascii로 변환하는 기능 추가. 밴드 지정 가능
 - gdalinfo를 이용해서 raster 파일의 다양한 정보를 추출해서 파일로 저장하는 기능 추가
 - aggregate files 에 있는 버그 수정
 - Bugs were fixed in the value extractor.
 - Raster calculator에서 A, B, C 중 하나를 폴더 지정해서 여러개 파일을 적용할 수 있는 기능 추가
 - Raster calculator에서 공백으로 구분하는 조건 삭제. 즉, 수식에서 공백으로 구분하지 않아도 됨
 - 거듭제곱 연산 추가

O 2019   
 - 'Tok'을 'ALTEK'으로 이름 수정
 - 조건 연산자에서 +, - 기호를 포함한 숫자에 관한 버그 수정
 - 다수의 파일의 좌표계를 변경하는 기능 추가
 - Text file을 appending 하는 기능 추가. 행방향, 열방향.
 - file 이름 변경시 폴더 지정 기능 추가
 - 파일리스트에서 natural comparer 기능 추가
 - calculator에서 '-' 값을 가지는 숫자나 문자가 맨 앞에 있을 경우, '+' 값으로 계산되는 버그 수정
 - raster file converter에서 ascii 파일의 소수점 자리수를 줄일 수 있는 기능 추가(ascii 파일 용량을 작게 하기 위해서)
 - [Get values from text files]의 [Extract texts in text file] 에서 여러개의 열을 추출할 수 있도록 기능 확장
 - raster file converter에서 ascii 파일 생성시, prj 파일 누락되는 버그 수정
 - gdal 업데이트  
   기존 : 2017.8.14 빌드 버전  
   신규 : 2019.3.23 빌드 버전  
 - 파일 리스트를 이용해서 배치파일 만드는 기능 추가

O 2020   
 - 파일 리스트를 정렬 버그 수정
 - ASCII 래스터 파일에서 기본적인 통계값 계산 기능 추가
 - ASCII 파일 calculator에서 수학함수(math, abs) 추가  
  
O 2021  
 - Text files editor에서 라인 인덱스 적용 버그 수정
 - Text files editor에서 처리 속도 향상
 - 다수의 ASCII raster file에서 셀별 최대값, 최소값, 합, 평균 등을 계산하고 하나의 래스터 파일을 만드는 기능 
 - Minor GUI 수정
 - Minor bug fix about cutting decimal parts.
 - Repository transferred 
 - gentle.dll was embedded in ALTEK.exe file and gentle.dll file was removed.  
 - The feature of extracting cell value was improved.  
 - Minor bug fix in processing nodata value of ASCII file in the ASCII raster calculator.

O 2022  
 - Revision in deleting temporary files.
 - Bug fix in "Edit text files > Search and replace line by line" feature.
 - Bug fix in "File name processor" for setting desitnation folder.  
 - Add "not equal operator (!=)" to ASC raster calculator.   
 - Add copying prjection files feature when making ASC file by "Get values from text files" menu.   
 - Add the feature of deleting file name by character index to "File name processor" menu.   

O 2023  
 - "Set texts between texts in a line" function was added.   
 - The function of removing columns from the text lines in the text files was added.   
 - The function of copying files using file name list was added.   

O 2024
 - "Converting NetCDF files to ASCII raster files" function was added.   
 - "Remove empty lines in the text files" function was added.   
 - The column mode in "Append text files" was improved.   

O 2025
 - The column mode in "Append text files" was improved.   
 - Bug fix in changing the file extension.   






 
