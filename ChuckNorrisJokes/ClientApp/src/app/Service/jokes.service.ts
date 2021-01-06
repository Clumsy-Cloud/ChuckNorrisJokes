import { Injectable } from '@angular/core';
import {  HttpClient } from '@angular/common/http';

import{Joke} from '../Model/joke.model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class JokesService {
  private apiUrl = 'http://localhost:43535/jokes/';
  //https://api.chucknorris.io/jokes

  constructor(
    private http: HttpClient
  ) { }

  // Get Random Joke
  getRandomJoke(): Observable<Joke> {
    return this.http.get<Joke>(this.apiUrl + 'random');
  }

  // Get Categories
  getCategories() {
    return this.http.get<string[]>(this.apiUrl +  'categories');
  }

  // Get joke by Category
  getCategoryJoke(category: string){
    return this.http.get<Joke>(this.apiUrl + `Category?category=${category}`);
  }

  // Get Search Jokes
  getSearchJokes(searchTerm : string) {
    return  this.http.get<{result: Joke[], amount:  number}>(this.apiUrl + `search?query=${searchTerm}`);
  }
}
