import "./App.css";
import { MainRoutes } from "./AppRoutes";
import { AuthenticationContextProvider } from "./features/authentication/components/AuthenticationProvider";
// import { UseMyContext } from './learnings/useContextLearn/UseMyContext'
import { LayoutComponent } from "./learnings/useChildrenLearn/LayoutComponent";
import { MainMenu } from "./shared/layout/MainMenu";
import Counter from "./learnings/reduxLearn/Counter"

function App() {
  // const getStorageStr = localStorage.getItem('player')
  // console.info(getStorageStr)

  // if (getStorageStr) {
  //   const player = JSON.parse(getStorageStr) as {surname: string}
  //   console.info(player)
  // } else {
  //   localStorage.setItem('player', JSON.stringify({surname: 'legolas'}))
  // }

  return (
    <>
      <div>
        <h2>Redux Complete Tutorial</h2>
        <Counter />
      </div>
      <AuthenticationContextProvider>
        <MainMenu></MainMenu>
        <LayoutComponent>
          <MainRoutes></MainRoutes>
        </LayoutComponent>
      </AuthenticationContextProvider>
    </>
  );
}

export default App;
