LOAD DATA INFILE 'data.csv'  	-- 입력할 파일의 경로
Replace
INTO TABLE zaioninfo              -- 입력받을 테이블의 이름
FIELDS                            -- 라인 내의 필드들을 구분하는 방법
    TERMINATED BY ','              -- 각 필드가 끝나는 구분문자를 지정해줌
    ENCLOSED BY ''                -- 구분된 필드 내에서 시작/끝 을 알리는 문자를 지정해줌
LINES                              -- 각 라인을 구분하는 방법
    TERMINATED BY '\n'          -- 각 라인이 끝나는 구분문자를 지정해줌
IGNORE 1 LINES