import { Component, OnInit } from '@angular/core';
import { JokesService } from '../Service/jokes.service';

import{Joke} from '../Model/joke.model';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css'],
})
export class HomeComponent implements  OnInit {
  jokes:  Joke [] = [];
  categories: string  [] = [];

  constructor(
    private jokesService: JokesService
  ){}

  ngOnInit(){
    this.jokesService.getCategories()
    .subscribe((categories: string[])  => {
      this.categories =  categories;

      this.jokesService.getRandomJoke()
      .subscribe((joke: Joke) => {
        this.jokes.push(joke);
      });
    });
  }

  //Search by Category
  searchbyCategory(category:string) {
    this.jokesService.getCategoryJoke(category)
    .subscribe((joke: Joke) => {
      this.jokes = [];
      this.jokes.push(joke);
    });
  }

  //Search by searchterm
  searchbySearchTerm(searchTerm: string){
  if (searchTerm !== '') {
    this.jokesService.getSearchJokes(searchTerm)
    .subscribe((jokes) => {
      this.jokes =jokes.result;
    });
  }
  }
}
