import {Component, OnInit} from '@angular/core';

@Component({
  selector: 'app-main-page',
  templateUrl: './main-page.component.html',
  styleUrls: ['./main-page.component.css']
})
export class MainPageComponent implements OnInit {
  slide: SlideInfo[];
  newFilms: NewFilms[][];
  allFilms: NewFilms[][];
  displayFilmsScope: number[];

  constructor() {
    this.slide = [new SlideInfo('The Irishman', '10', '../../assets/Images/ImgForPresentationPage/Slides/the-irishman.jpg', 16),
      new SlideInfo('Joker', '9.8', '../../assets/Images/ImgForPresentationPage/Slides/JokerFIlm.jpg', 18),
      new SlideInfo('Parasites', '8.1', '../../assets/Images/ImgForPresentationPage/Slides/1189411.jpg', 16),
      new SlideInfo('Downton Abbey', '7.7', '../../assets/Images/ImgForPresentationPage/Slides/downton-abbey.jpg', 20),
      new SlideInfo('RAMBO: last blood', '7.3', '../../assets/Images/ImgForPresentationPage/Slides/1*_thZ3hVed8XakCZe7Lua_Q.jpeg', 14)];
    this.newFilms =
      [[new NewFilms('Кримінальне чтиво', '../../assets/Images/ImgForPresentationPage/NewFilms/CriminalChtivo.jpg', '2D, 3D, 4DX', '18+', '-50%'),
        new NewFilms('Кримінальне чтиво', '../../assets/Images/ImgForPresentationPage/NewFilms/CriminalChtivo.jpg', '2D, 4DX', '18+', '-50%'),
        new NewFilms('Кримінальне чтиво', '../../assets/Images/ImgForPresentationPage/NewFilms/CriminalChtivo.jpg', '2D', '30+', '-50%'),
        new NewFilms('Кримінальне чтиво', '../../assets/Images/ImgForPresentationPage/NewFilms/CriminalChtivo.jpg', '2D', '8+', '-50%'),
        new NewFilms('Кримінальне чтиво', '../../assets/Images/ImgForPresentationPage/NewFilms/CriminalChtivo.jpg', '2D', '18+', '-50%')],
        [new NewFilms('Реинкарнация', '../../assets/Images/ImgForPresentationPage/NewFilms/Reincarnation.jpg', '2D', '18+', '-50%'),
          new NewFilms('Реинкарнация', '../../assets/Images/ImgForPresentationPage/NewFilms/Reincarnation.jpg', '2D', '18+', '-50%'),
          new NewFilms('Реинкарнация', '../../assets/Images/ImgForPresentationPage/NewFilms/Reincarnation.jpg', '2D', '18+', '-50%'),
          new NewFilms('Реинкарнация', '../../assets/Images/ImgForPresentationPage/NewFilms/Reincarnation.jpg', '2D', '18+', '-50%'),
          new NewFilms('', '../../assets/Images/ImgForPresentationPage/NewFilms/add.png', '', '', '', 'Побачити більше')]];

    this.displayFilmsScope = [0, 1];

    this.allFilms =
      [[new NewFilms('Кримінальне чтиво', '../../assets/Images/ImgForPresentationPage/NewFilms/CriminalChtivo.jpg', '2D, 3D, 4DX', '18+', '-50%'),
        new NewFilms('Кримінальне чтиво', '../../assets/Images/ImgForPresentationPage/NewFilms/CriminalChtivo.jpg', '2D, 4DX', '18+', '-50%'),
        new NewFilms('Кримінальне чтиво', '../../assets/Images/ImgForPresentationPage/NewFilms/CriminalChtivo.jpg', '2D', '30+', '-50%'),
        new NewFilms('Кримінальне чтиво', '../../assets/Images/ImgForPresentationPage/NewFilms/CriminalChtivo.jpg', '2D', '8+', '-50%'),
        new NewFilms('Кримінальне чтиво', '../../assets/Images/ImgForPresentationPage/NewFilms/CriminalChtivo.jpg', '2D', '18+', '-50%'),
        new NewFilms('Кримінальне чтиво', '../../assets/Images/ImgForPresentationPage/NewFilms/CriminalChtivo.jpg', '2D', '18+', '-50%'),
        new NewFilms('Кримінальне чтиво', '../../assets/Images/ImgForPresentationPage/NewFilms/CriminalChtivo.jpg', '2D', '18+', '-50%'),
        new NewFilms('Кримінальне чтиво', '../../assets/Images/ImgForPresentationPage/NewFilms/CriminalChtivo.jpg', '2D', '18+', '-50%')],
        [new NewFilms('Реинкарнация', '../../assets/Images/ImgForPresentationPage/NewFilms/Reincarnation.jpg', '2D', '18+', '-50%'),
          new NewFilms('Реинкарнация', '../../assets/Images/ImgForPresentationPage/NewFilms/Reincarnation.jpg', '2D', '18+', '-50%'),
          new NewFilms('Реинкарнация', '../../assets/Images/ImgForPresentationPage/NewFilms/Reincarnation.jpg', '2D', '18+', '-50%'),
          new NewFilms('Реинкарнация', '../../assets/Images/ImgForPresentationPage/NewFilms/Reincarnation.jpg', '2D', '18+', '-50%'),
          new NewFilms('Кримінальне чтиво', '../../assets/Images/ImgForPresentationPage/NewFilms/CriminalChtivo.jpg', '2D', '18+', '-50%'),
          new NewFilms('Кримінальне чтиво', '../../assets/Images/ImgForPresentationPage/NewFilms/CriminalChtivo.jpg', '2D', '18+', '-50%'),
          new NewFilms('Кримінальне чтиво', '../../assets/Images/ImgForPresentationPage/NewFilms/CriminalChtivo.jpg', '2D', '18+', '-50%'),
          new NewFilms('Кримінальне чтиво', '../../assets/Images/ImgForPresentationPage/NewFilms/CriminalChtivo.jpg', '2D', '18+', '-50%'),
        ],
        [new NewFilms('Реинкарнация', '../../assets/Images/ImgForPresentationPage/NewFilms/Reincarnation.jpg', '2D', '18+', '-50%'),
          new NewFilms('Реинкарнация', '../../assets/Images/ImgForPresentationPage/NewFilms/Reincarnation.jpg', '2D', '18+', '-50%'),
          new NewFilms('Реинкарнация', '../../assets/Images/ImgForPresentationPage/NewFilms/Reincarnation.jpg', '2D', '18+', '-50%'),
          new NewFilms('Реинкарнация', '../../assets/Images/ImgForPresentationPage/NewFilms/Reincarnation.jpg', '2D', '18+', '-50%'),
          new NewFilms('Кримінальне чтиво', '../../assets/Images/ImgForPresentationPage/NewFilms/CriminalChtivo.jpg', '2D', '18+', '-50%'),
          new NewFilms('Кримінальне чтиво', '../../assets/Images/ImgForPresentationPage/NewFilms/CriminalChtivo.jpg', '2D', '18+', '-50%'),
          new NewFilms('Кримінальне чтиво', '../../assets/Images/ImgForPresentationPage/NewFilms/CriminalChtivo.jpg', '2D', '18+', '-50%'),
          new NewFilms('Кримінальне чтиво', '../../assets/Images/ImgForPresentationPage/NewFilms/CriminalChtivo.jpg', '2D', '18+', '-50%'),
        ]];
  }

  ngOnInit() {
  }

  nextPage() {

    const rightArrow: any = document.getElementsByClassName('rightArrow')[0];
    const leftArrow: any = document.getElementsByClassName('leftArrow')[0];

    if (this.allFilms.length > (this.displayFilmsScope[1] + 2)) {
      this.displayFilmsScope = [this.displayFilmsScope[0] + 1, this.displayFilmsScope[1] + 1];
      leftArrow.src = '../../../assets/Images/ImgForPresentationPage/AllFilms/leftArrowRed.png';
      leftArrow.style.cursor = 'pointer';
    } else if (this.allFilms.length > (this.displayFilmsScope[1] + 1) && this.allFilms.length <= (this.displayFilmsScope[1] + 2)) {
      this.displayFilmsScope = [this.displayFilmsScope[1] + 1];
      leftArrow.src = '../../../assets/Images/ImgForPresentationPage/AllFilms/leftArrowRed.png';
      leftArrow.style.cursor = 'pointer';
    } else {
      /* alert(this.allFilms.length + '>' + (this.displayFilmsScope[1] + 1) +
        '&&' + this.allFilms.length + '<' + (this.displayFilmsScope[1] + 2)); */
    }
    if (this.displayFilmsScope.length === 1 || this.allFilms.length <= (this.displayFilmsScope[1] + 1)) {
      rightArrow.src = '../../../assets/Images/ImgForPresentationPage/AllFilms/leftArrowGrey.png';
      rightArrow.style.cursor = 'default';
      rightArrow.style.disabled = true;
    }
  }

  previousPage() {

    const rightArrow: any = document.getElementsByClassName('rightArrow')[0];
    const leftArrow: any = document.getElementsByClassName('leftArrow')[0];

    if (this.displayFilmsScope[0] !== 0 && this.displayFilmsScope.length !== 1) {
      this.displayFilmsScope = [this.displayFilmsScope[0] - 1, this.displayFilmsScope[1] - 1];
      rightArrow.src = '../../../assets/Images/ImgForPresentationPage/AllFilms/leftArrowRed.png';
      rightArrow.style.cursor = 'pointer';
    } else if (this.displayFilmsScope[0] !== 0 && this.displayFilmsScope.length === 1) {
      this.displayFilmsScope = [this.displayFilmsScope[0] - 2, this.displayFilmsScope[0] - 1];
      rightArrow.src = '../../../assets/Images/ImgForPresentationPage/AllFilms/leftArrowRed.png';
      rightArrow.style.cursor = 'pointer';
    }
    if (this.displayFilmsScope[0] === 0) {
      leftArrow.src = '../../../assets/Images/ImgForPresentationPage/AllFilms/leftArrowGrey.png';
      leftArrow.style.cursor = 'default';
      leftArrow.style.disabled = true;
    }
  }

  mathRound(num: number): number {
    return Math.round(num);
  }

  changeSlide(num: number) {
    const slides: any = [];
    for (let i = 0; i < 5; i++) {
      slides[i] = document.getElementsByClassName('Slide')[i];
      slides[i].style.opacity = '0';
      slides[i].style.transform = 'translateX(0)';
      slides[i].style.cursor = 'default';
    }
    if (num === 0) {

      slides[4].style.opacity = '0.5';
      // slides[4].style.right = '92%'; zxcvbhjkl
      slides[4].style.transform = 'translateX(102%)';
      slides[4].style.cursor = 'pointer';

      slides[num].style.transform = 'translateX(0)';
      slides[num].style.opacity = '1';

      slides[num + 1].style.opacity = '0.5';
      slides[num + 1].style.transform = 'translateX(-102%)';
      slides[num + 1].style.cursor = 'pointer';

    } else if (num === 4) {

      slides[num - 1].style.opacity = '0.5';
      slides[num - 1].style.transform = 'translateX(102%)';
      slides[num - 1].style.cursor = 'pointer';

      slides[num].style.transform = 'translateX(0)';
      slides[num].style.opacity = '1';

      slides[0].style.opacity = '0.5';
      slides[0].style.transform = 'translateX(-102%);';
      slides[0].style.cursor = 'pointer';

    } else {

      slides[num - 1].style.opacity = '0.5';
      slides[num - 1].style.transform = 'translateX(102%)';
      slides[num - 1].style.cursor = 'pointer';

      slides[num].style.transform = 'translateX(0)';
      slides[num].style.opacity = '1';

      slides[num + 1].style.opacity = '0.5';
      slides[num + 1].style.transform = 'translateX(-102%)';
      slides[num + 1].style.cursor = 'pointer';

    }
  }

}

export class SlideInfo {
  filmName: string;
  imdb: number;
  img: string;
  age: number;

  constructor(filmName, imdb, img, age) {
    this.filmName = filmName;
    this.imdb = imdb;
    this.img = img;
    this.age = age;
  }
}

export class NewFilms {
  name: string;
  img: string;
  technologies: string;
  age: string;
  discount: string;
  desc: string;

  constructor(name, img, technologies, age, discount, desc = '') {
    this.name = name;
    this.img = img;
    this.technologies = technologies;
    this.age = age;
    this.discount = discount;
    this.desc = desc;
  }
}
